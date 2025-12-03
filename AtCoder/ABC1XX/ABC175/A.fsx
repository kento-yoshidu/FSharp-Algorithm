// https://atcoder.jp/contests/abc175/tasks/abc175_a

let fn (s: string) =
    s.ToCharArray()
    |> Array.fold (fun (count, ans) c ->
        if c = 'R' then
            let count' = count + 1
            count', max ans count'
        else
            0, ans
    ) (0, 0)
    |> snd

printfn "%i" (fn "RRS")
//=> 2

printfn "%i" (fn "SSS")
//=> 0

printfn "%i" (fn "RSR")
//=> 1
