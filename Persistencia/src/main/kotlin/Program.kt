import kotlin.math.*
fun main(){
    var temp: Long
    var radix = 0
    print("Inserte un numero: ")
    var num = readLine()!!.toLong()
    var digitCount = log10(num.toDouble()).plus(1).toInt()
    do{
        temp = 1
        for (i in 0 until digitCount){
            temp *= num % 10
            num /= 10
        }
        num = temp
        radix++
        println("Paso ${radix}: ${num}")
        digitCount = log10(num.toDouble()).plus(1).toInt()
    }while(digitCount > 1)
    println("La persistencia multiplicativa es: ${radix}")
}