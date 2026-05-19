// https://atcoder.jp/contests/abc458/tasks/abc458_a

let fn (s: string) n =
    let len = String.length s
    s.[n .. len-n-1]

printfn "%s" (fn "chemotherapy" 3)
//=> mother

printfn "%s" (fn "thermometer" 4)
//=> mom

printfn "%s" (fn "burger" 1)
//=> urge
