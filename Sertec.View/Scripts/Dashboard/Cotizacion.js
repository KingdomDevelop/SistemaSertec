
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

/* Sumar dos números. */
function sumar(n,valor) {

    var total = 0;
    valor = parseInt(valor); // Convertir el valor a un entero (número).

    n1 = document.getElementById('CantidadId').value;
    n2 = document.getElementById('ValorUnitarioID').value;


    total = document.getElementById('SubTotalId').value//.innerHTML;
    // Aquí valido si hay un valor previo, si no hay datos, le pongo un cero "0".
    total = (total == null || total == undefined || total == "") ? 0 : total;

    /* Esta es la suma. */
    if (total == 0)
        total = (parseInt(total) + parseInt(valor));
    else
        total = (parseInt(n1) * parseInt(n2));
    // Colocar el resultado de la suma en el control "span".
    document.getElementById('SubTotalId').value = total;
}