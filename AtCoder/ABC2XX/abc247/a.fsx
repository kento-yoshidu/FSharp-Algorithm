// https://atcoder.jp/contests/abc247/tasks/abc247_a

let fn (s: string) =
    sprintf "0%s" s.[0..2]

printfn "%s" (fn "1011")
//=> 0101

printfn "%s" (fn "0000")
//=> 0000

printfn "%s" (fn "1111")
//=> 0111
