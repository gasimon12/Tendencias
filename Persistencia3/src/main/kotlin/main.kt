import kotlin.math.*

fun main() {
    val persistence: Persistence = Persistence()
    print("Inserte un numero: ")
    try{
        var num = readLine()!!.toLong()
        var result = persistence.calculate(num, 0)
        println("La persistencia multiplicativa es: $result")
    }catch(e: NumberFormatException){
        println("Error! Entrada invalida")
    }
}

class Persistence{
    fun calculate(num: Long, radix: Int): Int {
        var digitCount = log10(num.toDouble()).plus(1).toInt()
        var internal = num
        var index = radix
        var temp = 1L
        for (i in 0 until digitCount){
            temp *= internal % 10
            internal /= 10
        }
        digitCount = log10(temp.toDouble()).plus(1).toInt()
        index++
        if (digitCount > 1){
            return calculate(temp, index)
        }else{
            return index
        }
    }
}