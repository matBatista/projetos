var express = require('express');
var app = express();

//npm install ejs --save 
//app.set para setar o app para usar a engine ejs
app.set('view engine', 'ejs');


app.get('/home', function(req,res){
    res.render('../View/home')
});

app.get('/', function(req,res){
    res.json({name: "Matheus", idade: 25});
});


app.listen(3000,function (){
    console.log('Executando na porta 3000');
});