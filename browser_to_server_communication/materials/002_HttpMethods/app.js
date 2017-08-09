const path = require('path');
const express = require('express');
const ejs = require('ejs-locals');
const bodyParser = require('body-parser');

let cars = [
  {
    mark: "BMW",
    color: "red",
    year: 2009
  },
  {
    mark: "VW",
    year: 2009
  },
  {
    mark: "Ford",
    color: "blue"
  }
];

const app = express();

app.engine('html', ejs);
app.engine('ejs', ejs);
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'ejs');

// app.use(express.favicon('public/images/favicon.ico'));

// app.use(bodyParser());
app.use(bodyParser.urlencoded());
app.use(bodyParser.json());

app.use(express.static(path.join(__dirname, './public')));
app.use("/public", express.static(path.join(__dirname, './public')));


// Router GET queries
app.get('/', (req, res) => {
  res.render('index', { cars });
});

app.get('/car', function (req, res) {
  const { mark, color, year } = req.query;

  res.send(`Your query params for car: mark = ${mark || ""}, color = ${color || ""}, year = ${year || ""}<br /><a href="/">Home</a>`);
});

// Router POST queries
app.post('/car/add', function (req, res) {
  const { mark, color, year } = req.body;

  cars.push({ mark, color, year });

  console.log({ mark, color, year });
  console.log(cars);

  res.redirect('/');
});

app.post('/car/add-ajax-encoded', function (req, res) {
  console.log(req.query);
  const { mark, color, year } = req.query;

  cars.push({ mark, color, year });

  console.log({ mark, color, year });
  console.log(cars);

  // res.redirect('/');
  res.json({ mark, color, year });
});

app.post('/car/add-ajax-json-data', function (req, res) {
  console.log(req.body);
  const { mark, color, year } = req.body;

  cars.push({ mark, color, year });

  console.log({ mark, color, year });
  console.log(cars);

  // res.redirect('/');
  res.json({ mark, color, year });
});



app.listen(3000, function () {
  console.log('Example app listening on port 3000!')
})