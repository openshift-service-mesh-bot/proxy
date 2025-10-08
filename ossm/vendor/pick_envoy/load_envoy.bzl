
load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

OPENSSL_DISABLED_EXTENSIONS = [
            "envoy.tls.key_providers.cryptomb",
            "envoy.tls.key_providers.qat",
            "envoy.quic.deterministic_connection_id_generator",
            "envoy.quic.crypto_stream.server.quiche",
            "envoy.quic.proof_source.filter_chain",
        ]

def load_envoy():
    http_archive(
        name = "envoy",
        sha256 = "4d933c4aeac3f55855cb633525c944ac7e8647d2f46f97bfc564db8fb9e1692a",
        strip_prefix = "envoy-openssl-c09d0e55fbc2814458c11224df2ed35a3e1964d3",
        url = "https://github.com/envoyproxy/envoy-openssl/archive/c09d0e55fbc2814458c11224df2ed35a3e1964d3.tar.gz",
        patch_args = ["-p1"],
        patches = [
            "@io_istio_proxy//ossm/patches:use-cmake-from-host.patch",
            ],
    )
