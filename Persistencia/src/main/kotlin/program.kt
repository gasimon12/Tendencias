import kotlin.math.*

fun main(){
    var temp: Long
    var radix = 0
    println("Inserte un numero: ")
    var num = readLine()!!.toLong()
    var digitCount = log10(num.toDouble()).plus(1).toInt()
    do{
        temp = 1
        for(i in 0 until digitCount){
            temp *= num % 10
            num /= 10
        }
        digitCount = log10(temp.toDouble()).plus(1).toInt()
        num = temp
        radix++
    }while(digitCount > 1)
    println("La persistencia multiplicativa es: ${radix}")
}