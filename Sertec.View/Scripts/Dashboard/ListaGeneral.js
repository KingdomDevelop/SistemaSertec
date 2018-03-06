$(function () {
    $contenido = $("#contenido");
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
        }
    });

}