// https://atcoder.jp/contests/abc371/tasks/abc371_a

let fn ab ac bc =
    if ab = ac && ac = bc then
        "B"
    elif ab = ac && ac <> bc then
        "C"
    else
        "A"

printfn "%s" (fn '<' '<' '<')
//=> B

printfn "%s" (fn '<' '<' '>')
//=> C
