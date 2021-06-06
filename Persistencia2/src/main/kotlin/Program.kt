import java.lang.NumberFormatException
import kotlin.math.*

fun main(){
    print("Inserte el numero: ")
    var run = true
    var num = 0L
    var internal: Long
    var perst = 0
    try {
        num = readLine()!!.toLong()
    }catch(e : NumberFormatException){
        println("Error: Formato invalido!!")
        run = false
    }
    if (run){
        var digitCount = log10(num.toDouble()).plus(1).toInt()
        do{
            internal = 1
            for(i in 0 until digitCount){
                internal *= num % 10
                num /= 10
            }
            num = internal
            digitCount = log10(num.toDouble()).plus(1).toInt()
            perst++
        }while(digitCount > 1)

    }
}