$(function () {
    $contenido = $("#contenido");
    $facturacion = $("#facturacion");
    $conVenta = $("#condicionVenta");
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