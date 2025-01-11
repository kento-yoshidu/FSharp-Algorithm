// https://atcoder.jp/contests/abc381/tasks/abc381_a

let run n (s: string) =
    if n % 2 = 0 then
        "No"
    else
        let left =
            s.[..((n+1)/2-2)] |> Seq.forall((=) '1')

        let slash =
            s.[(n + 1) / 2 - 1] = '/'

        let right =
            s.[(n+1)/2..] |> Seq.forall((=) '2')

        if left && slash && right then
            "Yes"
        else
            "No"

printfn "%s" (run 5 "11/22")
//=> Yes

printfn "%s" (run 1 "/")
//=> Yes

printfn "%s" (run 4 "1/22")
//=> No

printfn "%s" (run 4 "1/22")
//=> No
