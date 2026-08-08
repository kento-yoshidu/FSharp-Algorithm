// https://atcoder.jp/contests/abc360/tasks/abc360_a

let fn (s: string) =
    let index c = s |> Seq.findIndex ((=) c)

    if index 'R' < index 'M' then
        "Yes"
    else
        "No"

printfn "%s" (fn "RSM")
//=> Yes

printfn "%s" (fn "SMR")
//=> No
