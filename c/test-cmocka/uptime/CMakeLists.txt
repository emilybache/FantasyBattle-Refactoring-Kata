project(uptime-cmocka C)

add_library(proc_uptime proc_uptime.c)

add_executable(uptime uptime.c)

target_link_libraries(uptime proc_uptime)
set_property(TARGET
                 uptime
             PROPERTY
                 LINK_FLAGS
                     "${DEFAULT_LINK_FLAGS}")

add_cmocka_test(test_uptime
                SOURCES test_uptime.c
                LINK_LIBRARIES cmocka-static)
set_property(TARGET
                 test_uptime
             PROPERTY
                 LINK_FLAGS
                    "${DEFAULT_LINK_FLAGS} -Wl,--wrap=uptime")
