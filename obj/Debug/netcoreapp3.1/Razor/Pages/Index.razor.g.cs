#pragma checksum "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8567b837f62923b91998c13b5fbf7bad04f32ac"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea5_.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Tarea5_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Tarea5_.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dropright");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "a");
            __builder.AddContent(6, "Hola ");
            __builder.AddContent(7, 
#nullable restore
#line 10 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                 nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " ");
            __builder.AddContent(9, 
#nullable restore
#line 10 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                         apellido

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, "! ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 13 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                   foto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "alt", "foto");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row bg-light");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table-bordered");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.AddMarkupContent(27, @"<thead class=""thead-dark"">
            <tr>
                <th>Titulo</th>
                <th>Descripcion</th>
                <th>Valor Monetario</th>
                <th>Fecha</th>
                <th>Lugar</th>
                <th>Latitud, Longitud</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(28, "tbody");
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 32 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
             if (Secretos.Where(u => u.Usuario == id).Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                 foreach (var secreto in Secretos.Where(s=> s.Usuario == id))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                    ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 37 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                             secreto.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 38 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                             secreto.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 39 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                             secreto.Valor_Moneda

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 40 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                             secreto.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 41 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                             secreto.Lugar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 42 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                             secreto.Lat_y_Long

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "td");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "btn btn-dark");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                   (() => SetSecretoUpdate(secreto))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.OpenElement(57, "td");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-danger");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                     (() => BorrarSecreto(secreto))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 46 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                ");
            __builder.AddMarkupContent(65, "<tr><td colspan=\"6\"><strong>No se han encontrado secretos</strong></td></tr>\r\n");
#nullable restore
#line 52 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row m-5");
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-5 bg-light m-2 justify-content-start");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.AddMarkupContent(76, "<div class=\"p-3 mb-3 bg-primary text-white text-center\">Agregar nuevo secreto</div>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(77);
            __builder.AddAttribute(78, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 60 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                          NuevoSecre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.AddMarkupContent(84, "<label for=\"name\">Titulo</label>\r\n                ");
                __builder2.OpenElement(85, "input");
                __builder2.AddAttribute(86, "type", "text");
                __builder2.AddAttribute(87, "id", "titulo");
                __builder2.AddAttribute(88, "class", "form-control");
                __builder2.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                                  NuevoSecre.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NuevoSecre.Titulo = __value, NuevoSecre.Titulo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group");
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.AddMarkupContent(96, "<label for=\"quantity\">Descripcion</label>\r\n                ");
                __builder2.OpenElement(97, "input");
                __builder2.AddAttribute(98, "type", "text");
                __builder2.AddAttribute(99, "id", "descripcion");
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                                 NuevoSecre.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NuevoSecre.Descripcion = __value, NuevoSecre.Descripcion));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group");
                __builder2.AddMarkupContent(107, "\r\n                ");
                __builder2.AddMarkupContent(108, "<label for=\"quantity\">Valor Monetario</label>\r\n                ");
                __builder2.OpenElement(109, "input");
                __builder2.AddAttribute(110, "type", "text");
                __builder2.AddAttribute(111, "id", "valor");
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                           NuevoSecre.Valor_Moneda

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NuevoSecre.Valor_Moneda = __value, NuevoSecre.Valor_Moneda));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n            ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group");
                __builder2.AddMarkupContent(119, "\r\n                ");
                __builder2.AddMarkupContent(120, "<label for=\"Description\">Fecha</label>\r\n                ");
                __builder2.OpenElement(121, "input");
                __builder2.AddAttribute(122, "type", "text");
                __builder2.AddAttribute(123, "id", "fecha");
                __builder2.AddAttribute(124, "class", "form-control");
                __builder2.AddAttribute(125, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                           NuevoSecre.Fecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(126, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NuevoSecre.Fecha = __value, NuevoSecre.Fecha));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n            ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "form-group");
                __builder2.AddMarkupContent(131, "\r\n                ");
                __builder2.AddMarkupContent(132, "<label for=\"Description\">Lugar</label>\r\n                ");
                __builder2.OpenElement(133, "input");
                __builder2.AddAttribute(134, "type", "text");
                __builder2.AddAttribute(135, "id", "lugar");
                __builder2.AddAttribute(136, "class", "form-control");
                __builder2.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                           NuevoSecre.Lugar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NuevoSecre.Lugar = __value, NuevoSecre.Lugar));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n            ");
                __builder2.OpenElement(141, "div");
                __builder2.AddAttribute(142, "class", "form-group");
                __builder2.AddMarkupContent(143, "\r\n                ");
                __builder2.AddMarkupContent(144, "<label for=\"Description\">Latitud, Longitud</label>\r\n                ");
                __builder2.OpenElement(145, "input");
                __builder2.AddAttribute(146, "type", "text");
                __builder2.AddAttribute(147, "id", "lat_long");
                __builder2.AddAttribute(148, "class", "form-control");
                __builder2.AddAttribute(149, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                              NuevoSecre.Lat_y_Long

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(150, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NuevoSecre.Lat_y_Long = __value, NuevoSecre.Lat_y_Long));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n            ");
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "class", "text-center p-3 mb-3");
                __builder2.AddMarkupContent(155, "\r\n                ");
                __builder2.OpenElement(156, "button");
                __builder2.AddAttribute(157, "class", "btn btn-info");
                __builder2.AddAttribute(158, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                       AgregarSecreto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(159, " Agregar Secreto");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(162, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "col-5 bg-light m-2 justify-content-end");
            __builder.AddMarkupContent(166, "\r\n        ");
            __builder.AddMarkupContent(167, "<div class=\"p-3 mb-1 bg-primary text-white text-center\">Editar Secreto</div>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(168);
            __builder.AddAttribute(169, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 95 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                          EditarSecre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(171, "\r\n            ");
                __builder2.OpenElement(172, "div");
                __builder2.AddAttribute(173, "class", "form-group");
                __builder2.AddMarkupContent(174, "\r\n                ");
                __builder2.AddMarkupContent(175, "<label for=\"name\">Titulo</label>\r\n                ");
                __builder2.OpenElement(176, "input");
                __builder2.AddAttribute(177, "type", "text");
                __builder2.AddAttribute(178, "id", "titulo");
                __builder2.AddAttribute(179, "class", "form-control");
                __builder2.AddAttribute(180, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 98 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                                  EditarSecre.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(181, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EditarSecre.Titulo = __value, EditarSecre.Titulo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(182, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\r\n            ");
                __builder2.OpenElement(184, "div");
                __builder2.AddAttribute(185, "class", "form-group");
                __builder2.AddMarkupContent(186, "\r\n                ");
                __builder2.AddMarkupContent(187, "<label for=\"price\">Descripcion</label>\r\n                ");
                __builder2.OpenElement(188, "input");
                __builder2.AddAttribute(189, "type", "text");
                __builder2.AddAttribute(190, "id", "descripcion");
                __builder2.AddAttribute(191, "class", "form-control");
                __builder2.AddAttribute(192, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 102 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                                 EditarSecre.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(193, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EditarSecre.Descripcion = __value, EditarSecre.Descripcion));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(194, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\r\n            ");
                __builder2.OpenElement(196, "div");
                __builder2.AddAttribute(197, "class", "form-group");
                __builder2.AddMarkupContent(198, "\r\n                ");
                __builder2.AddMarkupContent(199, "<label for=\"quantity\">Valor Monetario</label>\r\n                ");
                __builder2.OpenElement(200, "input");
                __builder2.AddAttribute(201, "type", "text");
                __builder2.AddAttribute(202, "id", "valor");
                __builder2.AddAttribute(203, "class", "form-control");
                __builder2.AddAttribute(204, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 106 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                           EditarSecre.Valor_Moneda

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(205, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EditarSecre.Valor_Moneda = __value, EditarSecre.Valor_Moneda));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(206, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(207, "\r\n            ");
                __builder2.OpenElement(208, "div");
                __builder2.AddAttribute(209, "class", "form-group");
                __builder2.AddMarkupContent(210, "\r\n                ");
                __builder2.AddMarkupContent(211, "<label for=\"Description\">Fecha</label>\r\n                ");
                __builder2.OpenElement(212, "input");
                __builder2.AddAttribute(213, "type", "text");
                __builder2.AddAttribute(214, "id", "fecha");
                __builder2.AddAttribute(215, "class", "form-control");
                __builder2.AddAttribute(216, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 110 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                           EditarSecre.Fecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(217, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EditarSecre.Fecha = __value, EditarSecre.Fecha));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(218, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(219, "\r\n            ");
                __builder2.OpenElement(220, "div");
                __builder2.AddAttribute(221, "class", "form-group");
                __builder2.AddMarkupContent(222, "\r\n                ");
                __builder2.AddMarkupContent(223, "<label for=\"Description\">Lugar</label>\r\n                ");
                __builder2.OpenElement(224, "input");
                __builder2.AddAttribute(225, "type", "text");
                __builder2.AddAttribute(226, "id", "lugar");
                __builder2.AddAttribute(227, "class", "form-control");
                __builder2.AddAttribute(228, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 114 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                           EditarSecre.Lugar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(229, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EditarSecre.Lugar = __value, EditarSecre.Lugar));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(230, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(231, "\r\n            ");
                __builder2.OpenElement(232, "div");
                __builder2.AddAttribute(233, "class", "form-group");
                __builder2.AddMarkupContent(234, "\r\n                ");
                __builder2.AddMarkupContent(235, "<label for=\"Description\">Latitud, Longitud</label>\r\n                ");
                __builder2.OpenElement(236, "input");
                __builder2.AddAttribute(237, "type", "text");
                __builder2.AddAttribute(238, "id", "fecha");
                __builder2.AddAttribute(239, "class", "form-control");
                __builder2.AddAttribute(240, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 118 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                                           EditarSecre.Lat_y_Long

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(241, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EditarSecre.Lat_y_Long = __value, EditarSecre.Lat_y_Long));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(242, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(243, "\r\n            ");
                __builder2.OpenElement(244, "div");
                __builder2.AddAttribute(245, "class", "text-center p-3 mb-3");
                __builder2.AddMarkupContent(246, "\r\n                ");
                __builder2.OpenElement(247, "button");
                __builder2.AddAttribute(248, "class", "btn btn-info");
                __builder2.AddAttribute(249, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
                                                       EditarSecreto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(250, " Actualizar Secreto");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(251, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(252, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(253, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(254, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Index.razor"
       

    List<Tarea5_.Models.Secreto> Secretos = new List<Tarea5_.Models.Secreto>();
    List<Tarea5_.Models.Usuario> Usuarios = new List<Tarea5_.Models.Usuario>();
    private Blazored.SessionStorage.ISessionStorageService _sessionStorage;
    string cedu, nombre, apellido, foto;
    int id;

    protected override async Task OnInitializedAsync()
    {
        await RefrescarSecretos();
        _sessionStorage = sessionStorage;
        Usuarios = await servicios.GetUsuariosAsync();

        await Datos();
    }

    private async Task RefrescarSecretos()
    {
        Secretos = await servicio.GetSecretosAsync();

    }

    private async Task Datos()
    {
        cedu = await sessionStorage.GetItemAsync<string>("cedula");
        var usu = Usuarios.FirstOrDefault(u => u.Cedula.Equals(cedu));
        if (usu == null)
        {
            await iJSRuntime.InvokeVoidAsync("Reload");
        }
        else
        {
            id = usu.Id;
            nombre = usu.Nombre;
            apellido = usu.Apellido;
            foto = usu.Foto;
        }

    }

    public Tarea5_.Models.Secreto NuevoSecre { get; set; } = new Models.Secreto();

    private async Task AgregarSecreto()
    {
        NuevoSecre.Usuario = id;

        await servicio.AgregarSecreto(NuevoSecre);

        NuevoSecre = new Models.Secreto();

        await RefrescarSecretos();
    }

    Tarea5_.Models.Secreto EditarSecre = new Models.Secreto();
    private void SetSecretoUpdate(Tarea5_.Models.Secreto secreto)
    {
        EditarSecre = secreto;

    }

    private async Task EditarSecreto()
    {
        await servicio.EditarSecreto(EditarSecre);
        EditarSecre = new Models.Secreto();
        await RefrescarSecretos();
    }

    private async Task BorrarSecreto(Tarea5_.Models.Secreto secreto)
    {

        await servicio.BorrarSecreto(secreto);

        await RefrescarSecretos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime iJSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tarea5_.Servicios.UsuarioServicio servicios { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tarea5_.Servicios.SecretoServicio servicio { get; set; }
    }
}
#pragma warning restore 1591
