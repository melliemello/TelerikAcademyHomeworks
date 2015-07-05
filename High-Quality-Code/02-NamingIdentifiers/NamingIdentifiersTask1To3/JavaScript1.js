function browserIsMozilla(event, arguments) {
    var windowElement = window,
        engine = windowElement.navigator.appCodeName,
        isMozilla = engine == "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}