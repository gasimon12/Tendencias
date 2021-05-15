defmodule M do
    def f(arg1, arg2, arg3) do
        redM = String.to_integer(arg1)
        greenM = String.to_integer(arg2)
        blueM = String.to_integer(arg3)
        redH = Integer.to_string(redM, 16)
        greenH = Integer.to_string(greenM, 16)
        blueH = Integer.to_string(blueM, 16)
        IO.puts(redH <> greenH <> blueH)
    end
end

[arg1, arg2, arg3] = System.argv
IO.puts M.f(arg1, arg2, arg3)
