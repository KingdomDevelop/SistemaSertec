$(function () {
    $contenido = $("#contenido");
    $facturacion = $("#facturacion");
    $conVenta = $("#condicionVenta");
    $apro = $("#aprobacion");
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
            verFacturacion($cotizacionId);
            verCondicionVenta($cotizacionId);
            verAprobacion($cotizacionId);
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