const { log } = require('console');
const { lookup } = require('dns');
const fs=require('fs')
fs.exists('./path.js',(exist)=>{
    if(exist)
    {
        console.log("File exists");
    }

})
fs.stat('./path.js',(err,data)=>{
    if(!err)
    {
        console.log(data);
    }

})
fs.rename('./path.js','./pathh.js',(err)=>{
    if(err)
    {
        console.log(err);
    }
    else
    {
        console.log("Renamed");
    }
}) 
fs.writeFile("demo.txt","heloo",(err)=>
{
    if(err)
    {
        console.log(err)
    }
})

fs.appendFile("demo.txt"," hii",(err)=>{})
fs.readFile("demo.txt",(err,data)=>console.log(data.toString()))