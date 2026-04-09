// https://atcoder.jp/contests/abc372/tasks/abc372_a

let fn (s: string) =
    s
    |> Seq.filter ((<>) '.')
    |> System.String.Concat

printfn "%s" (fn ".v.")
//=> v

printfn "%s" (fn "chokudai")
//=> chokudai

printfn "%s" (fn "...")
//=>
