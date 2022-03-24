var express = require('express');
var app = express();

//npm install ejs --save 
//app.set para setar o app para usar a engine ejs
app.set('view engine', 'ejs');


app.get('/home', function(req,res){
    res.render('../View/home')
});

app.get('/form/:nome/:sobrenome?', function(req,res){
    res.send('<h1> ' + req.params.nome +  ' ' + (req.params.sobrenome == null ? '' : req.params.sobrenome )+' </h1>');
});

app.get('/', function(req,res){
    res.json({name: "Matheus", idade: 25});
});

app.get('/cadastro', function(req,res){
    let name = req.query["nome"];
    let sobrenome = req.query["sobrenome"];
    if(name){
    res.send('<h1> ' + name + sobrenome +' </h1>');
    }else
    {res.send('');}
});

app.listen(3000,function (){
    console.log('Executando automatico com nodemon');
});