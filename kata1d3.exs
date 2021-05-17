defmodule Color do
    def convert(input) do
    for n <- 0..2, do:
    Enum.at(input, n)
    |> Integer.to_string(16)
    |> IO.write
    end
end

input = System.argv
|> Enum.map(&String.to_integer/1)
Color.convert(input)