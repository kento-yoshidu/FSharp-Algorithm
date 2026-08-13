// https://atcoder.jp/contests/abc459/tasks/abc459_a

let fn x =
    "HelloWorld".[0..x-2] + "HelloWorld".[x..]

printfn "%s" (fn 5)
//=> HellWorld

printfn "%s" (fn 9)
//=> HelloWord

printfn "%s" (fn 1)
//=> elloWorld
