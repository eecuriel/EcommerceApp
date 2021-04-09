using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AdminPortal.Models;
using Blazored.LocalStorage;
using Blazored.SessionStorage;

namespace AdminPortal.Services
{
    public class ItemCategoryDataService 
    {

        string  shortName ="";
        string requestState = "";
        string message ="";
        private HttpClient http {get; set;}
        private ILocalStorageService localStorage { get; set; }
        private ISessionStorageService  sessionStorage {get;set;}

        public ItemCategoryDataService(ILocalStorageService _localStorage,HttpClient _http,ISessionStorageService  _sessionStorage)
        {
            localStorage = _localStorage;
            http =_http;
            sessionStorage = _sessionStorage;
            
        }
    
    public async ValueTask<string[]>  StoreValidationByShortName(string value) 
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
            
            var Uri =  $"api/Store/Stores/{shortName}";
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

    public async ValueTask<string> StoreValidationByUser() {

        if (http.DefaultRequestHeaders.Authorization == null) {
        var token  =  await sessionStorage.GetItemAsync<string>("token");
        http.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }
        var ownerId = await localStorage.GetItemAsStringAsync("Id");
        string navEvaluation ="";
        var Uri =  $"api/Store/Stores/UserId/{ownerId}";
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

    public async ValueTask<string> getStoreName() {

        if (http.DefaultRequestHeaders.Authorization == null) {
        var token  =  await sessionStorage.GetItemAsync<string>("token");
        http.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }   

        var ownerId = await localStorage.GetItemAsStringAsync("Id");
        string storeName ="";

        var Uri =  $"api/Store/Stores/UserId/{ownerId}";
        var response = await http.GetAsync(Uri);
        var result = await response.Content.ReadFromJsonAsync<Store>();
            var UserId = result.UserId;
            if (UserId == ownerId){
                storeName = result.StoreName;
            } 
            return storeName;
    } 

    public async Task<Store> getStoreData() {

        if (http.DefaultRequestHeaders.Authorization == null) {
        var token  =  await sessionStorage.GetItemAsync<string>("token");
        http.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }
        
        var ownerId = await localStorage.GetItemAsStringAsync("Id");
        string storeName ="";
        var Uri =  $"api/Store/Stores/UserId/{ownerId}";
        var response = await http.GetAsync(Uri);
        var result = await response.Content.ReadFromJsonAsync<Store>();
            var UserId = result.UserId;
            if (UserId == ownerId){
                storeName = result.StoreName;
            } 
            return result;
    } 

    public async Task<ResponseState> putStoreLogo(MultipartFormDataContent storeLogoData) {

        if (http.DefaultRequestHeaders.Authorization == null) {
        var token  =  await sessionStorage.GetItemAsync<string>("token");
        http.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }        
        var ownerId = await localStorage.GetItemAsStringAsync("Id");
        var Uri =  $"api/Store/UpdateStore/StorePic/{ownerId}";
        var response = await http.PutAsync(Uri,storeLogoData);
        var result = await response.Content.ReadFromJsonAsync<ResponseState>();

        return result;
    } 

    }

} 
