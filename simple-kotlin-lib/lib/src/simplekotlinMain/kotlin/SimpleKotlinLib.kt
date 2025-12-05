// @file:OptIn(kotlinx.cinterop.ExperimentalForeignApi::class)
@OptIn(kotlin.experimental.ExperimentalNativeApi::class)
//import kotlinx.cinterop.CName

@CName("add_ints")
fun addInts(a: Int, b: Int): Int = a + b

@OptIn(kotlin.experimental.ExperimentalNativeApi::class)
@CName("multiply_double")
fun multiplyDouble(x: Double, y: Double): Double = x * y