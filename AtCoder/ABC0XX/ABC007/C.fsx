// https://atcoder.jp/contests/abc007/tasks/abc007_3

let fn r c sy sx gy gx (a: string list) =
    let sy, sx, gy, gx = sy-1, sx-1, gy-1, gx-1

    let grid =
        a
        |> List.map (fun s -> s.ToCharArray())
        |> List.toArray

    let dist = Array.init r (fun _ -> Array.create c -1)

    let dirs = [(0, -1); (-1, 0); (0, 1); (1, 0)]

    let rec bfs (queue: (int * int) list) =
        match queue with
        | [] -> ()
        | (i, j) :: rest ->
            let nexts =
                dirs
                |> List.choose (fun (di, dj) ->
                    let ni, nj = i+di, j+dj

                    if ni >= 0 && ni < r && nj >= 0 && nj < c then
                        if grid.[ni].[nj] = '.' && dist.[ni].[nj] = -1 then
                            dist.[ni][nj] <- dist.[i][j] + 1
                            Some (ni, nj)
                        else
                            None
                    else
                        None)

            bfs (rest @ nexts)

    dist.[sy].[sx] <- 0

    bfs [ (sy, sx) ]

    dist.[gy].[gx]


printfn "%i" (fn 7 8 2 2 4 5 ["########"; "#......#"; "#.######"; "#..#...#"; "#..##..#"; "##.....#"; "########"])
//=> 11

printfn "%i" (fn 5 8 2 2 2 4 ["########"; "#.#....#"; "#.###..#"; "#......#"; "########";])
//= 10
