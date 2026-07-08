// https://atcoder.jp/contests/abc344/tasks/abc344_a

let fn (s: string) =
    match s.Split('|') with
    | [| a; _; c |] -> a + c
    | _                              -> failwith "Unreachable"

printfn "%s" (fn "atcoder|beginner|contest")
//=> atcodercontest

printfn "%s" (fn "|spoiler|")
//=>

printfn "%s" (fn "||xyz")
//=> xyz
