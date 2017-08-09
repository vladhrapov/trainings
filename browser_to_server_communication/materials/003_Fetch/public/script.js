function jsonToHtml(json) {
  if (json.data && json.data.fruits) {
    return json.data.fruits
      .map(function (fruit) {
        return "<li>" + fruit + "</li>";
      })
      .reduce(function (res, fruit) {
        return res + fruit;
      }, "");
  }

  return "No data";
}

function callEndpoint(url, parserCallback, successCallback) {
  return function () {
    fetch(url)     // Вызов ф-и fetch с передачей url
      .then(parserCallback)
      .then(successCallback);
  };
}

window.onload = function () {
  document.getElementById("btnGetTemplate").onclick = callEndpoint(
    '/public/partial-template.html',
    function (response) { return response.text(); },
    function (template) { document.getElementById("template-output").innerHTML += template; }
  );

  document.getElementById("btnGetJson").onclick = callEndpoint(
    '/public/data.json',
    function (response) { return response.json(); },
    function (json) { document.getElementById("json-output").innerHTML += jsonToHtml(json); }
  )

  //document.getElementById("btnGetTemplate").onclick =  function () {
  // fetch('/public/partial-template.html')     // Вызов ф-и fetch с передачей url
  //   .then(function (response) {  // Ответ с сервера приходит в параметр response
  //     return response.text();    // response дает доступ к телу ответа в нужном формате, заголовкам headers, статусу status и некоторым другим полям ответа
  //   })
  //   .then(function (template) {
  //     console.log(template);   // В data лежит наш ответ с сервера
  //     document.getElementById("template-output").innerHTML += template;//xhr.responseText;
  //   });
  // }

  //document.getElementById("btnGetJson").onclick = function () {
  // fetch('/public/data.json')     // Вызов ф-и fetch с передачей url
  //   .then(function (response) {  // Ответ с сервера приходит в параметр response
  //     return response.json();    // response дает доступ к телу ответа в нужном формате, заголовкам headers, статусу status и некоторым другим полям ответа
  //   })
  //   .then(function (json) {
  //     console.log(json);   // В data лежит наш ответ с сервера
  //     document.getElementById("json-output").innerHTML += jsonToHtml(json);
  //   });
  // }
}