cmake_minimum_required(VERSION 3.10)
project(stbimage)

set(CMAKE_C_STANDARD 11)

include_directories(./)

add_library(stbimage SHARED main.c)

