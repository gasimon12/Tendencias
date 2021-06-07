fun main() {
    print("Inserte un numero: ")
    try{
        var num = readLine()!!.toLong()

    }catch(e: NumberFormatException){
        println("Error! Entrada invalida")
    }
}

class Persistence{

}