function jsonToHtml(responseText) {
  var json = JSON.parse(responseText);

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

window.onload = function () {
  document.getElementById("btnGetTemplate").onclick = function () {

    var xhr = new XMLHttpRequest();                                   // Создание объекта для HTTP запроса.
    xhr.open("GET", "public/partial-template.html", false);           // Настройка объекта для отправки синхронного GET запроса
    xhr.send();                                                       // Отправка запроса, так как запрос является синхронным, следующая строка кода выполнится только после получения ответа со стороны сервера.
    document.getElementById("template-output").innerHTML += xhr.responseText;  // responseText - текст ответа полученного с сервера.
  }

  document.getElementById("btnGetJson").onclick = function () {

    var xhr = new XMLHttpRequest();             // Создание объекта для HTTP запроса.
    xhr.open("GET", "public/data.json", true);  // Настройка объекта для отправки асинхронного GET запроса

    // функция-обработчик срабатывает при изменении свойства readyState
    // Значения свойства readyState:
    // 0 - Метод open() еще не вызывался
    // 1 - Метод open() уже был вызван, но метод send() еще не вызывался.
    // 2 - Метод send() был вызван, но ответ от сервера еще не получен
    // 3 - Идет прием данных от сервера. Для значения 3 Firefox вызывает обработчик события несколько раз IE только один раз.
    // 4 - Ответ от сервера полностью получен (Запрос успешно завершен).

    xhr.onreadystatechange = function () {
      if (xhr.readyState == 4) { // если получен ответ
        if (xhr.status == 200) { // и если статус код ответа 200
          document.getElementById("json-output").innerHTML += jsonToHtml(xhr.responseText); // responseText - текст ответа полученного с сервера.
        }
      }
    }

    xhr.send();                              // Отправка запроса, так как запрос асинхронный сценарий продолжит свое выполнение. Когда с сервера придет ответ сработает событие onreadystatechange
    
  }
}