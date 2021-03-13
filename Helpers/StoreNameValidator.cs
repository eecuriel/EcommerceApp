using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using AdminPortal.Models;
using Blazored.LocalStorage;

namespace AdminPortal.Helpers
{
    public class StoreNameValidator 
    {

        string  shortName ="";
        string requestState = "";
        string message ="";
        
    public async ValueTask<string[]>  StoreValidationByShortName(string value, HttpClient http,ILocalStorageService localStorage) 
    {
        
        shortName = value;
        
        if (shortName.Length==0 || shortName == "" || shortName == null)
        {
            requestState = "invalid";
            string[] responseArray ={requestState,"This field can't be blank"};
            return responseArray;
        }   
        else 
        {
        if (shortName.Length < 10) {
            requestState = "invalid";
            string[] responseArray ={requestState,"Your store short name must have 10 characters"};
            return responseArray;

        } else {

            //wait time for each request
            //Thread.Sleep(2000);
             //wait time for each request
            var Uri =  $"api/Store/Stores/{shortName}";
            //var token = await localStorage.GetItemAsStringAsync("token");
            //http.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await http.GetAsync(Uri);
            var result = await response.Content.ReadFromJsonAsync<StoreValidation>();
            if (result.StoreShortName == shortName){
                requestState = "invalid";
                message = "Exist a store with this name";

            }  else if(result.StoreShortName != shortName) {
                requestState = "valid";
                message = "";
                await localStorage.SetItemAsync("StoreName", value);
                
            }
            
            string[] responseArray ={requestState,message};
            return responseArray;
        }
            
        }
    
    } 

    public async ValueTask<string> StoreValidationByUser(HttpClient http,ILocalStorageService localStorage ) {

        var ownerId = await localStorage.GetItemAsStringAsync("Id");
        string navEvaluation ="";

        var Uri =  $"api/Store/Stores/UserId/{ownerId}";
        //End point unique authorization
        var token = await localStorage.GetItemAsStringAsync("token");
        http.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        //End point unique authorization
        var response = await http.GetAsync(Uri);
        var result = await response.Content.ReadFromJsonAsync<Store>();
            var UserId = result.UserId;
            if (UserId == ownerId){
                navEvaluation = "1";
            } else {
                navEvaluation = "2";
            }

            return navEvaluation;
    } 

    }

} 
