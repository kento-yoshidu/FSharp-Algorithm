// https://atcoder.jp/contests/abc427/tasks/abc427_a

let fn s =
    let len = String.length s
    let mid = len / 2

    s.[0..mid-1] + s.[mid+1..]

printfn "%s" (fn "ABCDE")
//=> ABDE

printfn "%s" (fn "OOO")
//=> OO

printfn "%s" (fn "ATCODER")
//=> ATCDER
