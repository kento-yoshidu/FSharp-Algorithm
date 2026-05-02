// https://atcoder.jp/contests/abc431/tasks/abc431_c

let fn _n _m k h b =
    let head =
        h
        |> Array.sort
        |> Array.take k

    let body =
        b
        |> Array.sort
        |> Array.rev
        |> Array.take k
        |> Array.rev

    if Array.forall2 (<=) head body then
        "Yes"
    else
        "No"

printfn "%s" (fn 6 6 3 [| 2; 7; 1; 8; 2; 8 |] [| 1; 8; 2; 8; 4; 5 |])
//=> Yes

printfn "%s" (fn 1 1 1 [| 43 |] [| 1 |])
//=> No

printfn "%s" (fn 1 1 1 [| 100 |] [| 100 |])
//=> Yes

printfn "%s" (fn 12 15 12 [| 748; 169; 586; 329; 972; 529; 432; 519; 408; 587; 138; 249;|] [| 656; 114; 632; 299; 984; 755; 404; 772; 155; 506; 832; 854; 353; 465; 387 |])
//=> Yes
