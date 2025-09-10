import { setCameraX, setCameraY, setCameraZoom, getCamera } from "./render.js"; }
export function setCamera(patch) {
    if (!patch) return;
    if (typeof patch.x === "number") state.camera.x = patch.x;
    if (typeof patch.y === "number") state.camera.y = patch.y;
    if (typeof patch.zoom === "number") state.camera.zoom = clamp(patch.zoom, state.camera.minZoom, state.camera.maxZoom);
}

export function pan(dx, dy) {
    // dx, dy � � �������� ��������; ��������� � ������� � ������ ����
    setCameraX(dx / getCamera().zoom);
    setCameraY(dy / getCamera().zoom);
}


export function zoomAt(screenX, screenY, factor) {
    const pre = screenToWorld(screenX, screenY);
    setCameraZoom(clamp(state.camera.zoom * factor, state.camera.minZoom, state.camera.maxZoom));

    // ������ ����� ��� �������� ����������
    const post = screenToWorld(screenX, screenY);
    setCameraX(pre.x - post.x);
    setCameraY(pre.y - post.y);
}

//���������� ������ � ������� ����������
export function screenToWorld(x, y) {
    // x, y � ���������� ������ canvas � CSS-��������
    const { w, h } = state.viewport;
    const { x: cx, y: cy, zoom } = state.camera;
    return {
        x: (x - w / 2) / zoom + cx,
        y: (y - h / 2) / zoom + cy,
    };
}

//���������� � ������� ����������� � ���������� ������
export function worldToScreen(x, y) {
    const { w, h } = state.viewport;
    const { x: cx, y: cy, zoom } = state.camera;
    return {
        x: (x - cx) * zoom + w / 2,
        y: (y - cy) * zoom + h / 2,
    };
}