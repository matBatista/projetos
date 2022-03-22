var express = require('express');
var app = express();


app.get('/', function(req,res){
    res.json({name: "Matheus", idade: 25});
});


app.listen(3000,function (){
    console.log('Executando na porta 3000');
});