var Uf = null;
var Flete = null;
var valorHP = null;

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
            actualizarTotalHP();
            actualizarTotalRep();
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
            actualizarTotalHP();
            actualizarTotalRep();
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

/*Obt Valor Unidad de Fomento y Hora Par a Resumen Mano Obra*/
function ObtValores(n, valor) {
    var total = 0;
    valor = parseInt(valor); // Convertir el valor a un entero (número).
    if (n == 1) {
        n1 = document.getElementById('ValorUF').value;
    } else if (n == 2) {
        n2 = document.getElementById('ValorHP').value;
    }

}

/* Sumar dos números. */
function sumar(n, valor) {

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

function guardaDatosCalculo() {
    var dataType = 'application/json; charset=utf-8';

    if (document.getElementById('ValorUF').value != "") {
        Uf = document.getElementById('ValorUF').value;
    }
    if (document.getElementById('ValorFlete').value != "") {
        Flete = document.getElementById('ValorFlete').value;
    }

    if (document.getElementById('ValorFlete').value != "") {
        valorHP = document.getElementById('ValorFlete').value;
    }
    var model = {
        ValorUF: document.getElementById('ValorUF').value,
        ValorHP: document.getElementById('ValorHP').value,
        ValorFlete: document.getElementById('ValorFlete').value
    }

    $.ajax({
        type: "POST",
        url: urlDatosCalculo,
        datatype: "json",
        data: model,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
        }
    });
}

function actualizarTotalHP() {
    $.ajax({
        type: "GET",
        url: urlTotalHP,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $("#TotalHP").val(response);
            var result = valorHP * response;
            $("#idSubtotalHP").val(result);
            var valor = document.getElementById('idRecargoHHEE');
            if (valor.value != "") {
                actualizarTotalRecargo(valor);
            } else {
                actualizaTotalManoObra();
            }
        }
    });
}

function actualizarTotalRecargo($valor) {
    if ($valor != "") {
        var subtotalHP = document.getElementById('idSubtotalHP').value;
        var total = subtotalHP * (($valor.value) / 100);
        $("#idValorRecargo").val(total);
        actualizaTotalManoObra();
    } else {
        $("#idValorRecargo").val("");
    }
}

function actualizaTotalManoObra() {
    var recargo = null;
    var subtotalHP = document.getElementById('idSubtotalHP').value;
    var total = document.getElementById('idValorRecargo');
    if (total.value == "") {
        recargo = "0";
    }
    var manoObra = parseInt(recargo) + parseInt(subtotalHP);
    $("#idTotalManoObra").val(manoObra);
    $("#TotalValorManoObra").val(manoObra);
    calculaSubTotal();
}

function actualizarTotalRep() {
    $.ajax({
        type: "GET",
        url: urlSubTotalRep,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $("#idTotalRepuestos").val(response);
            calculaSubTotal();
        }
    });
}

function actualizaTotalFletes($fletes) {
    if ($fletes.value != "") {
        if (Flete != null) {
            var totalFlete = parseInt($fletes.value) * Flete;
            $("#idTotalFletes").val(totalFlete);
            $("#idFlete").val(totalFlete);
            calculaSubTotal();
        }
    }
}

function calculaSubTotal() {

    var totalManoObra = null;
    var totalRepuesto = null;
    var totalTercero = null;
    var totalFletes = null;

    var manoObra = document.getElementById('TotalValorManoObra');
    if (manoObra.value != "") {
        totalManoObra = manoObra.value
    } else {
        totalManoObra = "0";
    }

    var repuesto = document.getElementById('idTotalRepuestos');
    if (repuesto.value != "") {
        totalRepuesto = repuesto.value
    } else {
        totalRepuesto = "0";
    }

    var fletes = document.getElementById('idFlete');
    if (fletes.value != "") {
        totalFletes = fletes.value
    } else {
        totalFletes = "0";
    }

    var subtotal = parseInt(totalManoObra) + parseInt(totalRepuesto) + parseInt(totalFletes);

    $("#idSubtotal").val(subtotal);
    var valVenta = parseInt(subtotal * (3 / 100));
    $("#idValorVenta").val(valVenta);
    var marVenta = parseInt(subtotal * (20 / 100));
    $("#idMargenVenta").val(marVenta);

    var total = subtotal + valVenta + marVenta;
    $("#idTotalNeto").val(total);
}
