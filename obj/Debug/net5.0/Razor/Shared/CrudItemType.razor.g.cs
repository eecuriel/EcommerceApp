#pragma checksum "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "994cd391766ce7f93ab73b5b411ead192f37c337"
// <auto-generated/>
#pragma warning disable 1591
namespace Project_FrontEnd.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Project_FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Project_FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using AdminPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    public partial class CrudItemType : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card shadow mb-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header py-3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "float-start");
            __builder.OpenElement(8, "h3");
            __builder.AddAttribute(9, "class", "m-0 font-weight-bold text-primary text-end");
            __builder.AddContent(10, 
#nullable restore
#line 10 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                                        CrudName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "position-absolute top-0 end-0");
            __builder.AddAttribute(14, "style", "right: 0;");
            __builder.OpenComponent<Blazorise.Button>(15);
            __builder.AddAttribute(16, "class", "btn btn-success btn-icon-split");
            __builder.AddAttribute(17, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                                             NewItemShowModal

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "<span class=\"icon text-white-50\"><i class=\"fas fa-plus\"></i></span>\r\n                        ");
                __builder2.OpenElement(20, "span");
                __builder2.AddAttribute(21, "class", "text");
                __builder2.AddContent(22, "New ");
                __builder2.AddContent(23, 
#nullable restore
#line 17 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                CrudName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            \r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-body");
            __builder.OpenComponent<Blazorise.Table>(27);
            __builder.AddAttribute(28, "Hoverable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.TableHeader>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.TableRow>(32);
                    __builder3.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(34);
                        __builder4.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(36, "Col1");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(38);
                        __builder4.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(40, "Col2");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(42);
                        __builder4.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(44, "Col3");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(46);
                        __builder4.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(48, "Col4");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(50);
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(52, "Edit");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(54);
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(56, "Delete");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.OpenComponent<Blazorise.TableBody>(58);
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 35 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                     for (var i=0; i < RowNumber;i++)
                    {   

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.TableRow>(60);
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableRowHeader>(62);
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(64, 
#nullable restore
#line 38 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                         i

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(66);
                        __builder4.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(68, "Mark");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(69, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(70);
                        __builder4.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(72, "Otto");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(73, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(74);
                        __builder4.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(76, "mdo");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(78);
                        __builder4.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Button>(80);
                            __builder5.AddAttribute(81, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 42 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                        EdittemShowModal

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(83, "<span class=\"oi oi-spreadsheet\"></span>");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(84, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(85);
                        __builder4.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Button>(87);
                            __builder5.AddAttribute(88, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 43 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                        DeleteAlertShowModal

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(90, "<span class=\"oi oi-trash\"></span>");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 45 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        \r\n        \r\n        ");
            __builder.OpenComponent<Blazorise.Modal>(92);
            __builder.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.ModalContent>(94);
                __builder2.AddAttribute(95, "IsCentered", "true");
                __builder2.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ModalHeader>(97);
                    __builder3.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.ModalTitle>(99);
                        __builder4.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(101, "New ");
                            __builder5.AddContent(102, 
#nullable restore
#line 57 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                 CrudName

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(103, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(104);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.ModalBody>(106);
                    __builder3.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Project_FrontEnd.Shared.ItemTypeForm>(108);
                        __builder4.AddAttribute(109, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 61 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                             itemTypeRegistration

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(110, "itemTypeData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AdminPortal.Models.ItemsType>(
#nullable restore
#line 61 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                                                 itemsType

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.ModalFooter>(112);
                    __builder3.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Button>(114);
                        __builder4.AddAttribute(115, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 64 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                               Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(116, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 64 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                          NewItemHideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(118, "Close");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(119, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.Button>(120);
                        __builder4.AddAttribute(121, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 65 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                               Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(122, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 65 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                        NewItemHideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(124, "Save Changes");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(125, (__value) => {
#nullable restore
#line 54 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                     NewItemModal = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(126, "\r\n    \r\n\r\n    \r\n        ");
            __builder.OpenComponent<Blazorise.Modal>(127);
            __builder.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.ModalContent>(129);
                __builder2.AddAttribute(130, "IsCentered", "true");
                __builder2.AddAttribute(131, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ModalHeader>(132);
                    __builder3.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.ModalTitle>(134);
                        __builder4.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(136, "Edit ");
                            __builder5.AddContent(137, 
#nullable restore
#line 75 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                  CrudName

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(138, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(139);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(140, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.ModalBody>(141);
                    __builder3.AddAttribute(142, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Project_FrontEnd.Shared.ItemTypeForm>(143);
                        __builder4.AddAttribute(144, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 79 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                             itemTypeRegistration

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(145, "itemTypeData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AdminPortal.Models.ItemsType>(
#nullable restore
#line 79 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                                                 itemsType

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.ModalFooter>(147);
                    __builder3.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Button>(149);
                        __builder4.AddAttribute(150, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 82 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                               Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(151, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 82 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                          EditItemHideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(152, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(153, "Close");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(154, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.Button>(155);
                        __builder4.AddAttribute(156, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 83 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                               Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(157, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 83 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                        EditItemHideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(158, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(159, "Save Changes");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(160, (__value) => {
#nullable restore
#line 72 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                     EdititemModal = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(161, "\r\n    \r\n\r\n    \r\n    \r\n        ");
            __builder.OpenComponent<Blazorise.Modal>(162);
            __builder.AddAttribute(163, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.ModalContent>(164);
                __builder2.AddAttribute(165, "IsCentered", "true");
                __builder2.AddAttribute(166, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ModalBody>(167);
                    __builder3.AddAttribute(168, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(169, "\r\n                Are you sure to delete this item?\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(170, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.ModalFooter>(171);
                    __builder3.AddAttribute(172, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Button>(173);
                        __builder4.AddAttribute(174, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 97 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                               Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(175, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 97 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                        DeleteAlertHideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(176, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(177, "Yes");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(178, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.Button>(179);
                        __builder4.AddAttribute(180, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 98 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                               Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(181, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 98 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                                                          DeleteAlertHideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(182, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(183, "No");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(184, (__value) => {
#nullable restore
#line 91 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
                     DeleteAlertModal = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\CrudItemType.razor"
       
    [Parameter] public string CrudName {get; set;}
    private ItemsType itemsType = new ItemsType();

    private int RowNumber = 5;

    private async void itemTypeRegistration(){

        
    }
    // reference to the modal component
    private Modal NewItemModal;
    private Modal EdititemModal;

    private Modal DeleteAlertModal;
    private void NewItemShowModal()
    {
        NewItemModal.Show();
    }

    private void NewItemHideModal()
    {
        NewItemModal.Hide();
    }

    private void EdittemShowModal()
    {
        EdititemModal.Show();
    }

    private void EditItemHideModal()
    {
        EdititemModal.Hide();
    }

    private void DeleteAlertShowModal()
    {
        DeleteAlertModal.Show();
    }
    private void DeleteAlertHideModal()
    {
        DeleteAlertModal.Hide();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591