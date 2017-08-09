window.onload = function () {
  var httpModule = HttpModule();

  document.getElementById('submit-encoded').onclick = httpModule.submitEncodedDataHandler;
  document.getElementById('submit-json-data').onclick = httpModule.submitJsonHandler;
};

function HttpModule() {
  var fields = document.forms[0].getElementsByTagName("input");

  function readyStateChangeHandler(xhr) {
    return function () {
      if (xhr.readyState == 4) {
        if (xhr.status == 200) {
          console.log(xhr.responseText);
          addNewCar(JSON.parse(xhr.responseText));
        }
      }
    }
  }

  function submitJsonHandler() {
    var xhr = new XMLHttpRequest();

    xhr.open("POST", '/car/add-ajax-json-data', true);
    xhr.setRequestHeader('Content-type', 'application/json; charset=utf-8');

    var car = {};
    setCarObject(car);

    xhr.onreadystatechange = readyStateChangeHandler(xhr);

    xhr.send(JSON.stringify(car));
  }

  function setCarObject(car) {
    Array.prototype.forEach.call(fields, function (field) {
      if (field.type === "text") {
        car[field.name] = field.value;
      }
    });
  }

  function submitEncodedDataHandler() {
    var xhr = new XMLHttpRequest();

    var queryString = getEncodedQueryString(encodeURIComponent);

    xhr.open("POST", '/car/add-ajax-encoded?' + queryString, true);

    xhr.onreadystatechange = readyStateChangeHandler(xhr);

    xhr.send();
  }

  function getEncodedQueryString(encodeCallback) {
    return Array.prototype.map.call(fields, function (field, index) {
      if (field.type === "text") {
        console.log(field, field.name, field.value, field.type);
        var value = !!encodeCallback ? encodeCallback(field.value) : field.value;
        return field.name + "=" + value;
      }
    })
      .join("&")
      .slice(0, -1);
  }

  function addNewCar(res) {
    var linkNode = document.createElement("a");
    var queryString = `mark=${res.mark || ""}&color=${res.color || ""}&year=${res.year || ""}`;
    linkNode.setAttribute("href", "http://localhost:3000/car?" + queryString);
    linkNode.text = queryString.split("&").join(", ");

    document.getElementById("car-list").appendChild(linkNode).appendChild(document.createElement("br"));
  }

  return {
    submitEncodedDataHandler,
    submitJsonHandler
  }
}


