// https://atcoder.jp/contests/abc335/tasks/abc335_a

let fn (s: string) =
    s.Substring(0, s.Length - 1) + "4"

printfn "%s" (fn "hello2023")
//=> hello2024

printfn "%s" (fn "worldtourfinals2023")
//=> worldtourfinals2024

printfn "%s" (fn "2023")
//=> 2024

printfn "%s" (fn "20232023")
//=> 20232024
