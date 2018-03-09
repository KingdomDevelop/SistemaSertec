$(function () {
    $contenido = $("#contabilidad");
    $facturacion = $("#facturacion");
    $conVenta = $("#condicionVenta");
    $apro = $("#aprobacion");
    $ope = $("#operaciones");
});

function verContabilidad($cotizacionId) {


    $.ajax({
        type: "POST",
        url: urlVerContabilidad + "/" + $cotizacionId,
        datatype: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($contenido).html(response);
            verAprobacion($cotizacionId);
            verFacturacion($cotizacionId);
            verCondicionVenta($cotizacionId);
            verOperaciones($cotizacionId);
            document.getElementById('tabEmpl').click();
        }
    });

}

function verFacturacion($cotizacionId) {
    $.ajax({
        type: "POST",
        url: urlVerFacturacion + "/" + $cotizacionId,
        datatype: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($facturacion).html(response);
        }
    });
}


function verCondicionVenta($cotizacionId) {
    $.ajax({
        type: "POST",
        url: urlVerCondicionVenta + "/" + $cotizacionId,
        datatype: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($conVenta).html(response);
        }
    });
}


function verAprobacion($cotizacionId) {
    $.ajax({
        type: "POST",
        url: urlVerAprobacion + "/" + $cotizacionId,
        datatype: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($apro).html(response);
        }
    });
}

function verOperaciones($cotizacionId) {
    $.ajax({
        type: "POST",
        url: urlVerOperaciones + "/" + $cotizacionId,
        datatype: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($ope).html(response);
        }
    });
}

function SeleccionTexto() {
    if (document.getElementById('descOtro').checked) {
        document.getElementById("TextBox_DescOtro").disabled = false;
    } else {
        document.getElementById("TextBox_DescOtro").disabled = true;
    }
}

function SeleccionTextoFP() {

    if (document.getElementById('apCuota').checked) {
        document.getElementById("TextBox_Cuotas").disabled = false;
    } else {
        document.getElementById("TextBox_Cuotas").disabled = true;
    }
    if (document.getElementById('apOtro').checked) {
        document.getElementById("TextBox_Otros").disabled = false;
    } else {
        document.getElementById("TextBox_Otros").disabled = true;
    }
}

function SeleccionTextoMA() {
    if (document.getElementById('maOtro').checked) {
        document.getElementById("TextBox_OtroMedioApro").disabled = false;
    } else {
        document.getElementById("TextBox_OtroMedioApro").disabled = true;
    }
}


function CrearCondicionVenta($contabilidad) {

    var descCinco = false;
    var descQuince = false;
    var descOtro = false;
    var textOtro = null;

    var pagoCien = false;
    var pagoCincuenta = false;
    var pagoCuota = false;
    var txtCuotas = null;
    var otroPago = false;
    var txtOtroPago = null;

    var firmado = false;
    var orden = false;
    var otraApro = false;
    var txtOtraApro = null;

    if (document.getElementById('descCinco').checked) { descCinco = true; }
    if (document.getElementById('descQuince').checked) { descQuince = true; }
    if (document.getElementById('descOtro').checked) { descOtro = true; }
    if (document.getElementById('descOtro').checked) { textOtro = document.getElementById('TextBox_DescOtro').value; }

    if (document.getElementById('apCien').checked) { pagoCien = true; }
    if (document.getElementById('apCincuenta').checked) { pagoCincuenta = true; }
    if (document.getElementById('apCuota').checked) { pagoCuota = true; }
    if (document.getElementById('apCuota').checked) { txtCuotas = document.getElementById('TextBox_Cuotas').value; }
    if (document.getElementById('apOtro').checked) { otroPago = true; }
    if (document.getElementById('apOtro').checked) { txtOtroPago = document.getElementById('TextBox_Otros').value; }

    if (document.getElementById('maCopia').checked) { firmado = true; }
    if (document.getElementById('maOrden').checked) { orden = true; }
    if (document.getElementById('maOtro').checked) { otraApro = true; }
    if (document.getElementById('maOtro').checked) { txtOtraApro = document.getElementById('TextBox_DescOtro').value; }


    var dataType = 'application/json; charset=utf-8';
    var data = {
        ExisteDatos: true,
        NumeroContabilidad: $contabilidad,
        DescuentoCinco: descCinco,
        DescuentoQuince: descQuince,
        OtroDescuentos: descOtro,
        OtroDescuentoDescripcion: textOtro,
        PagoCien: pagoCien,
        PagoCincuenta: pagoCincuenta,
        PagoCuotas: pagoCuota,
        NumeroCuotas: txtCuotas,
        OtroPago: otroPago,
        OtroPagoDescripcion: txtOtroPago,
        PresupuestoFirmado: firmado,
        OrdenCompra: orden,
        OtraAprobacion: otraApro,
        OtraAprobacionDescripcion: txtOtraApro
    }


    $.ajax({
        type: "POST",
        url: urlCrearCondicionVenta,
        datatype: "json",
        data: data,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            verCondicionVenta($contabilidad);
        }
    });
}



function CrearAprobacion($cotizacion) {

    var dataType = 'application/json; charset=utf-8';
    var data = {
        Direccion: document.getElementById('TxtDire').value,
        PersonaAprobacion: document.getElementById('Txt_APROBPOR').value,
        TelefonoContacto: document.getElementById('Txt_TELCONTA').value,
        Cotizacion: $cotizacion
    }

    $.ajax({
        type: "POST",
        url: urlCrearAprobacion,
        datatype: "json",
        data: data,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($apro).html(response);
        }
    });
}


function CrearFacturacion($contabilidad) {

    var dataType = 'application/json; charset=utf-8';
    var data = {
        NumeroCuotas: document.getElementById('txtNumCuota').value,
        Factura: document.getElementById('txtNumFact').value,
        Valor: document.getElementById('txtValor').value,
        Mes: document.getElementById('txtMes').value,
        Contabilidad: $contabilidad
    }

    $.ajax({
        type: "POST",
        url: urlCrearFacturacion,
        datatype: "json",
        data: data,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Error");
        },
        success: function (response) {
            $($facturacion).html(response);
            $("#txtValor").val("");
            $("#txtMes").val("");
        }
    });
}

