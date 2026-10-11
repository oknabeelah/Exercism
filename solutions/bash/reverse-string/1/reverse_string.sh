#!/usr/bin/env bash

# ${#array[@]} -> returns the number of elements in an array

# main () {
#     echo "$1" | rev
# }

# main "$1"

main_alt () {
    # read the array backwards to return the string
    local input="$1" # take string input
    local reversed="" # bash doesnt use space around = when assigning variables!
    local i

    for ((i = ${#input} - 1; i >= 0; i--)); do # ${#input} -> returns the length of the string stored in input
        reversed+="${input:i:1}" # loops to adds 1 character starting at index [Lenght-1] to [0]
    done

    echo "$reversed"
}

main_alt "$1"
