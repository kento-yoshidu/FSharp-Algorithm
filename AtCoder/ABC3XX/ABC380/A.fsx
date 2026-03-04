// https://atcoder.jp/contests/abc380/tasks/abc380_a

let fn (n: string) =
    let str = n.ToString()

    if str |> Seq.sort |> System.String.Concat = "122333" then
        "Yes"
    else
        "No"

printfn "%s" (fn "123233")
//=> Yes

printfn "%s" (fn "123234")
//=> No

printfn "%s" (fn "323132")
//=> Yes

printfn "%s" (fn "500000")
//=> No
