// https://atcoder.jp/contests/abc453/tasks/abc453_a

let fn n s =
    s
    |> Seq.skipWhile (fun c -> c = 'o')
    |> Seq.toArray
    |> System.String

printfn "%s" (fn 7 "ooparts")
//=> parts

printfn "%s" (fn 6 "abcooo")
//=> abcooo

printfn "%s" (fn 5 "ooooo")
//=>
