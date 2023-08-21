project(sample-cmocka C)

add_cmocka_test(player_test
        SOURCES player_test.c
        LINK_LIBRARIES src cmocka-static)
add_cmocka_test_environment(add_test)

set_property(TARGET
        player_test
        PROPERTY
        LINK_FLAGS
        "${DEFAULT_LINK_FLAGS} -Wl,--wrap=calculation_is_authorized")

