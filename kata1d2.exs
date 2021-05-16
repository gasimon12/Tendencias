defmodule Color do
    def convert(red, green, blue) do
    hex1 = Integer.to_string(red, 16)
    hex2 = Integer.to_string(green, 16)
    hex3 = Integer.to_string(blue, 16)
    IO.puts(hex1 <> hex2 <> hex3)
    end
end

[red, green, blue] = System.argv
red = String.to_integer(red)
green = String.to_integer(green)
blue = String.to_integer(blue)
Color.convert(red, green, blue)