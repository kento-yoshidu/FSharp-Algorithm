// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_ae

open System

let fn ax ay bx by cx cy =
    let ax = float ax
    let ay = float ay
    let bx = float bx
    let by = float by
    let cx = float cx
    let cy = float cy

    let bax = ax - bx
    let bay = ay - by
    let bcx = cx - bx
    let bcy = cy - by
    let cax = ax - cx
    let cay = ay - cy
    let cbx = bx - cx
    let cby = by - cy

    let p =
        if bax * bcx + bay * bcy < 0.0 then
            1
        elif cax * cbx + cay * cby < 0.0 then
            3
        else
            2

    match p with
    | 1 ->
        sqrt (bax * bax + bay * bay)
    | 3 ->
        sqrt (cax * cax + cay * cay)
    | _ ->
        let s = abs (bax * bcy - bay * bcx)
        let bcLength = sqrt (bcx * bcx + bcy * bcy)

        s / bcLength

printfn "%f" (fn 0 5 1 1 3 0)
//=> 4.123106

printfn "%f" (fn -40 -30 -50 -10 -20 -20)
//=> 15.811388

printfn "%f" (fn 1000000000 1000000000 -1000000000 -1000000000 0 -1000000000)
//=> 2236067977.499790
