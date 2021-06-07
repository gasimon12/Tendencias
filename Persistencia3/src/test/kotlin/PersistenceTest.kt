import kotlin.test.*

internal class PersistenceTest{
    private val persistence: Persistence = Persistence()
    @Test
    fun number1(){
        assertEquals(1, persistence.calculate(2, 0))
    }
    @Test
    fun number2(){
        assertEquals(2, persistence.calculate(29, 0))
    }
    @Test
    fun number3(){
        assertEquals(3, persistence.calculate(47, 0))
    }
    @Test
    fun number4(){
        assertEquals(4, persistence.calculate(277, 0))
    }
    @Test
    fun number5(){
        assertEquals(5, persistence.calculate(769, 0))
    }
    @Test
    fun number6(){
        assertEquals(6, persistence.calculate(8867, 0))
    }
    @Test
    fun number7(){
        assertEquals(7, persistence.calculate(186889, 0))
    }
    @Test
    fun number8(){
        assertEquals(8, persistence.calculate(2678789, 0))
    }
    @Test
    fun number9(){
        assertEquals(9, persistence.calculate(26899889, 0))
    }
    @Test
    fun number10(){
        assertEquals(10, persistence.calculate(3778888999, 0))
    }
    @Test
    fun number11(){
        assertEquals(11, persistence.calculate(277777788888989, 0))
    }
}