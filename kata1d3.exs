
input = System.argv
|> Enum.map(&String.to_integer\1)
Color.convert(input)