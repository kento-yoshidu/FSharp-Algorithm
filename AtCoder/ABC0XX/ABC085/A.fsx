// https://atcoder.jp/contests/abc085/tasks/abc085_a

let fn (s: string) =
    match s.Split('/') with
    | [| _; m; d|] -> sprintf "2018/%s/%s" m d
    | _ -> ""

printfn "%s" (fn "2017/01/07")
//=> 2018/01/07

printfn "%s" (fn "2017/01/31")
//=> 2018/01/31
