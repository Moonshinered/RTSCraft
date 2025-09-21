import js from "@eslint/js";
import globals from "globals";

export default [
    {
        languageOptions: {
            globals: { ...globals.browser, ...globals.es2022 },
            sourceType: "module",
        }
    },
    js.configs.recommended,
    {
        rules: {
            "no-undef": "error",         // �������� � ���������� � ����� ������
            "no-unused-vars": "warn",    // ����������� � ��������������
            "eqeqeq": "error"            // ������ === ������ ==
        }
    }
];
