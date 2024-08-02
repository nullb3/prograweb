console.log("Hola mundo");

//Variables

var miString01 = "Cadena 01"
console.log(miString01);

var miInteger = 10

var suma = miString01 +" "+  miInteger;

console.log(suma);

console.log(typeof miString01);
console.log(typeof miInteger)

let miString02 = "Cadena 02";
console.log(miString02)

let miInteger02 = 20;
console.log(miInteger02)


//Distintos valores


var miBuleano =  true

console.log(typeof miBuleano)

miBuleano = null;

console.log(typeof miBuleano)

miBuleano = undefined

console.log(typeof miBuleano)

var edad = 20;

var nombre = "Pedro"

if(edad >= 18 && nombre == "Juan"){
    console.log("Mayor de edad")

}else{
    console.log("Menor de edad")
}

var cualquiera = null;

if(cualquiera){
    console.log("Mayor de edad")

}else{
    console.log("Menor de edad")
}

let miArreglo = ["Juan",3.14,"Maria",50, true]


console.log(typeof miArreglo[0])
console.log(typeof miArreglo[1])
console.log(typeof miArreglo[2])
console.log(typeof miArreglo[3])
console.log(typeof miArreglo[4])

if("pedro"=="pedro"){ 
    console.log("Si")
}else{
    console.log("no")
 }