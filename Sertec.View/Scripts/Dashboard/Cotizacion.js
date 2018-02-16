
$(function () {
    $divRepuesto = $("#repuestoList");
    $divTerceros = $("#terceroList");


    $("#btnCrearRep").click(function () { btnCrearPresupuesto(); return false; });

    $("#btnCrearTer").click(function () { btnCrearTerceros(); return false; });

});


function btnCrearPresupuesto() {

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
            $("#repuestoId").val("");
            $("#CantidadId").val("");
            $("#CodigoId").val("");
            $("#ValorUnitarioID").val("");
            $("#SubTotalId").val("");
            $("#HhId").val("");
            $($divRepuesto).html(response);
        }
    });
}

function btnCrearTerceros() {

    var dataType = 'application/json; charset=utf-8';
    var data = {
        Terceros: document.getElementById('tercerosId').value,
        ValTer: document.getElementById('valorTerceros').value,
    }

    $.ajax({
        type: "POST",
        url: urlAgregarTerceros,
        datatype: "json",
        data: data,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $("#tercerosId").val("");
            $("#valorTerceros").val("");
            $($divTerceros).html(response);
        }
    });
}

function eliminarRepuesto($repuestoId) {
    $.ajax({
        type: "POST",
        url: urlEliminarRepuesto + "/" + $repuestoId,
        datatype: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($divRepuesto).html(response);
        }
    });
}

function eliminarTerceros($tercerosId) {
    $.ajax({
        type: "POST",
        url: urlEliminarTerceros + "/" + $tercerosId,
        datatype: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($divTerceros).html(response);
        }
    });
}

function soloNumeros(e) {
    var key = window.Event ? e.which : e.keyCode
    return ((key >= 48 && key <= 57) || (key == 8))
}