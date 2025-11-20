// https://atcoder.jp/contests/abc171/tasks/abc171_a

let fn a =
    if System.Char.IsUpper a then
        "A"
    else
        "a"

printfn "%s" (fn 'B')
//=> A

printfn "%s" (fn 'a')
//=> a
