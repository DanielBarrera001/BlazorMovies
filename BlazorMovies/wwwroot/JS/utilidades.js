function obtenerCurrentCount() {
    DotNet.invokeMethodAsync("BlazorMovies", "ObtenerCurrentCount")
        .then(resultado => {
            console.log(`Conteo desde JS: ${resultado}`);
        })
}

function invocarIncrementCount(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}