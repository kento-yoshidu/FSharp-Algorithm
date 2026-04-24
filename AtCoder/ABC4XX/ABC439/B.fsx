// https://atcoder.jp/contests/abc439/tasks/abc439_b

let rec calc n (set: Set<int>) =
    if n = 1 then
        "Yes"
    elif set.Contains n then
        "No"
    else
        let set' = set.Add n

        let sum =
            n.ToString()
            |> Seq.sumBy (fun c ->
                let d = int (c - '0')
                d * d)

        calc sum set'


let fn n =
    let set = set []

    calc n set

printfn "%s" (fn 2026)
//=> Yes

printfn "%s" (fn 439)
//=> No

printfn "%s" (fn 440)
//=> Yes
