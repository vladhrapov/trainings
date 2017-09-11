var path = require("path");
var webpack = require("webpack");

module.exports = {
  entry: [
    './app/index.ts'
  ],
  output: {
    publicPath: '/public/',
    path: path.join(__dirname, '/public'),
    filename: "bundle.js"
  },
  module: {
    rules: [
      {
        test: /\.tsx?$/,
        loader: "ts-loader",
        exclude: /node_modules/
      }
    ]
  },
  resolve: {
    extensions: [".js", ".json", ".ts", ".tsx"]
  }
}