// https://atcoder.jp/contests/abc041/tasks/abc041_a

let run (s: string) i =
    s.[i-1]

printfn "%c" (run "atcoder" 3)
//=> c

printfn "%c" (run "beginner" 1)
//=> b

printfn "%c" (run "contest" 7)
//=> t

printfn "%c" (run "z" 1)
//=> z
