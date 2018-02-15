
// Variables Presupuesto
var $divIngresarRepuesto;
var idFormIngresar;

$(function () {
    $divListarFechas = $("#repuestoList");
    //idFormIngresar = "#formNuevoRepuesto";

    $("#btnCrearRep").click(function () { btnCrearAction(); return false; });
});


function btnCrearAction() {

    var dataType = 'application/json; charset=utf-8';
    var data = {
        Respuesto: document.getElementById('repuestoId').value,
        Cantidad: document.getElementById('CantidadId').value,
        Codigo: document.getElementById('CodigoId').value,
        ValorUnitario: document.getElementById('ValorUnitarioID').value,
        SubTotal: document.getElementById('SubTotalId').value,
        HoraParHombre: document.getElementById('HhId').value
    }


        $.ajax({
        type: "POST",
        url: urlAgregarRepuesto,
        datatype: "json",
        data: data,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($divListarFechas).html(response);
        }
    });
}

//function loadRepuestoSuccess() {
//    $($divListarFechas).html();
//    //    load(window.urlSiniestroCabecera, function () {
//    //});
//}

